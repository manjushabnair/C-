using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDelegates
{
    /// <summary>
    /// Notes: It is similar to the Equals method of the Object class (that we have discussed in the preceding), 
    /// the only difference between the two is that the Equals method of 
    /// The IEquatable interface is a generic method and it avoids the boxing and unboxing of objects t
    /// hat improves the performance
    /// </summary>
    public class SampleData : IEquatable<SampleData>, IComparable<SampleData>, IComparable
    {
        public int ID { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }

        public int CompareTo(SampleData? other) 
        {

            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return Value.CompareTo(this.Value);
        }

        public int CompareTo(object? obj)
        {
            if (ReferenceEquals(this, obj)) return 0;
            if (ReferenceEquals(null, obj)) return 1;
            return obj is SampleData other ? CompareTo(other) : throw new ArgumentException();
        }

        public static bool operator <()
    }
}
