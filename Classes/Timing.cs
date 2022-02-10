using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AlbumSplitter.Classes {

    /// <summary>Small class to represent a track's timing on the album file</summary>
    public class Timing {

        /// <summary>Timecode class to represent any time from 00:00:00.000 to 23:59:59.999</summary>
        public struct Timecode : IComparable, IEqualityComparer<Timecode> {

            /// <summary>Hours in this timecode</summary>
            [Range(0, 23)]
            public int Hours { get; set; } = 0;

            /// <summary>Minutes in this timecode</summary>
            [Range(0, 59)]
            public int Minutes { get; set; } = 0;

            /// <summary>Seconds in this timecode</summary>
            [Range(0, 59)]
            public int Seconds { get; set; } = 0;

            /// <summary>Miliseconds in this timecode</summary>
            [Range(0,999)]
            public int Miliseconds { get; set; } = 0;

            /// <summary>Total Miliseconds this timecode represents</summary>
            public int TotalMiliseconds => (Hours * 60 * 60 * 1000) + (Minutes * 60 * 1000) + (Seconds * 1000) + Miliseconds;

            public Timecode(int Hours, int Minutes, int Seconds, int Miliseconds) {
                this.Hours = Hours;
                this.Minutes = Minutes;
                this.Seconds = Seconds;
                this.Miliseconds= Miliseconds;
            }


            /// <summary>Creates a tiemcode</summary>
            /// <param name="Hours"></param>
            /// <param name="Minutes"></param>
            /// <param name="Seconds"></param>
            public Timecode(int Hours, int Minutes, int Seconds) { 
                this.Hours = Hours;
                this.Minutes = Minutes;
                this.Seconds = Seconds;
            }

            public Timecode(int Minutes, int Seconds) {

                Hours = Minutes / 60;
                this.Minutes = Minutes % 60;
                this.Seconds=Seconds;

            }

            public Timecode(int Miliseconds) {
                var Seconds = Miliseconds/1000;
                var TempMinutes = Seconds / 60;
                Hours = TempMinutes / 60;
                Minutes = TempMinutes % 60;

                this.Seconds = Seconds % 60;
                this.Miliseconds = Miliseconds % 1000;
            }

            public static Timecode FromString(string TimecodeString) {
                string[] SplitString = TimecodeString.Split(':');
                if (TimecodeString.Contains('.')) {
                    if (SplitString.Length != 3) {
                        if (SplitString.Length == 2) { TimecodeString = $"0:{TimecodeString}"; }
                        if (SplitString.Length == 1) { TimecodeString = $"0:0:{TimecodeString}"; }
                        SplitString = TimecodeString.Split(':');
                    }
                }

                List<int> IntSplits = new();

                for (int i = 0; i < SplitString.Length; i++) {
                    if (SplitString[i].Contains(".")) { 
                        string[] SubSplit = SplitString[i].Split('.');
                        IntSplits.Add(int.Parse(SubSplit[0]));
                        IntSplits.Add(int.Parse(SubSplit[1]));
                        continue;
                    }
                    IntSplits.Add(int.Parse(SplitString[i]));
                }

                return IntSplits.Count switch {
                    2 => new Timecode(IntSplits[0], IntSplits[1]),
                    3 => new Timecode(IntSplits[0], IntSplits[1], IntSplits[2]),
                    4 => new Timecode(IntSplits[0], IntSplits[1], IntSplits[2], IntSplits[3]),
                    _ => new Timecode(IntSplits[0]),
                };
            }

            /// <summary>Converts this time code to H:M:S</summary>
            /// <returns></returns>
            public override string ToString() => $"{Hours}:{Minutes}:{Seconds}.{Miliseconds}";

            public int CompareTo(object? obj) => obj is Timecode T ? TotalMiliseconds.CompareTo(T.TotalMiliseconds) : -1;

            public override bool Equals([NotNullWhen(true)] object? obj) => obj is Timecode T ? TotalMiliseconds.Equals(T.TotalMiliseconds) : base.Equals(obj);
            public bool Equals(Timecode x, Timecode y) => throw new NotImplementedException();
            public int GetHashCode([DisallowNull] Timecode obj) => throw new NotImplementedException();
            public override int GetHashCode() => TotalMiliseconds.GetHashCode();

            public static bool operator ==(Timecode left, Timecode right) => left.Equals(right);
            public static bool operator !=(Timecode left, Timecode right) => !(left == right);
            public static bool operator <(Timecode left, Timecode right) => left.CompareTo(right) < 0;
            public static bool operator <=(Timecode left, Timecode right) => left.CompareTo(right) <= 0;
            public static bool operator >(Timecode left, Timecode right) => left.CompareTo(right) > 0;
            public static bool operator >=(Timecode left, Timecode right) => left.CompareTo(right) >= 0;
        }

        public Timecode Start { get; set; } = new(0);

        public Timecode End { get; set; } = new(0);

        public Timing(Timecode Start, Timecode End) {
            if (Start > End) { throw new ArgumentException("Start must be before end"); }
            this.Start = Start; 
            this.End = End;
        }

        public Timecode Duration() => new(End.TotalMiliseconds - Start.TotalMiliseconds);
    }
}
