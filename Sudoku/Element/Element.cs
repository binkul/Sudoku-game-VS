using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Sudoku.Element
{
    class Element
    {
        public int Number { get; set; } = 0;
        public List<int> Candidates { get; } = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public Color FontColor { get; set; } = Color.Black;

        public Element()
        { }

        public Element(int number, List<int> candidates, Color fontColor)
        {
            Number = number;
            Candidates = candidates;
            FontColor = fontColor;
        }

        public void RemoveCandidate(int number) => Candidates.Remove(number);

        public int GetCandidate(int index) => Candidates[index];

        public int FetFirstCandidate() => Candidates[0];

        public int GetCandidateSize() => Candidates.Count();

        public override string ToString() => base.ToString() +
                "[Number: " + Number + "; " +
                "Candidates: " + Candidates + "]";
    }
}
