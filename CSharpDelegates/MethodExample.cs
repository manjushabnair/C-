using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDelegates
{
    public class MethodExample
    {
        public string ProcessData(SampleData sampledata)
        {
            return $"Name: {sampledata.Name} and Value: {sampledata.Value}. Type: {sampledata.GetType()}";
        }
        public string ProcessData(object sampledata)
        {
            return $"Type: {sampledata.GetType()}";
        }
        public string ProcessData(SampleData sampledata, int changeValueBy)
        {
            return $"Name: {sampledata.Name} and Value: {sampledata.Value + changeValueBy}. Type: {sampledata.GetType()}";
        }
    }
}
