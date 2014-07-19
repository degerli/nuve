﻿using System;
using System.Collections.Generic;
using System.Linq;
using Nuve.Orthographic;

namespace Nuve.Sentence
{
    /// <summary>
    /// Represents the accuracy of a SentenceSegmenter on a paragraph!
    /// </summary>
    internal class DetailedEvaluation : SimpleEvaluation
    {
        private readonly IEnumerable<int> _misses;
        private readonly IEnumerable<int> _hits;
        private readonly IEnumerable<int> _falseAlarms;
        private readonly int _eosCandidateCount;
        private readonly string _paragraph;

        public DetailedEvaluation(IEnumerable<int> hits, IEnumerable<int> misses, IEnumerable<int> falseAlarms,
            int eosCandidateCount, string paragraph) : base(hits.Count(), misses.Count(), falseAlarms.Count(), eosCandidateCount)
        {
            if (eosCandidateCount <= 0)
            {
                throw new ArgumentException(
                    "There must be at least one possible end of sentence character (EOS candidate) !");
            }
            _misses = misses;
            _hits = hits;
            _falseAlarms = falseAlarms;
            _eosCandidateCount = eosCandidateCount;
            _paragraph = paragraph;
        }

        private const int Margin = 25;
        
        private IEnumerable<string> GetParts(IEnumerable<int> indices)
        {
            var parts = new List<string>();
            int len = _paragraph.Length;
            foreach (int i in indices)
            {
                int start = i > Margin ? i - Margin : 0;
                int end = i < len - Margin ? i + Margin : len;
                parts.Add(_paragraph.SubstringJava(start, end));
            }
            return parts;
        }

        public void PrintMisses()
        {
            var misses = GetParts(_misses);
            PrintParts(misses);
        }

        public void PrintFalseAlarms()
        {
            var falseAlarms = GetParts(_falseAlarms);
            PrintParts(falseAlarms);
        }

        public void PrintHits()
        {
            var hits = GetParts(_hits);
            PrintParts(hits);
        }

        private void PrintParts(IEnumerable<string> parts )
        {
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }

        private bool Equals(DetailedEvaluation other)
        {
            return Equals(_misses, other._misses) && 
                Equals(_hits, other._hits) && 
                Equals(_falseAlarms, other._falseAlarms) && 
                _eosCandidateCount == other._eosCandidateCount && 
                string.Equals(_paragraph, other._paragraph);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((DetailedEvaluation) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (_misses != null ? _misses.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (_hits != null ? _hits.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (_falseAlarms != null ? _falseAlarms.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ _eosCandidateCount;
                hashCode = (hashCode*397) ^ (_paragraph != null ? _paragraph.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}