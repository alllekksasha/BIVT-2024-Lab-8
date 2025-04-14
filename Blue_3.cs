﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_3:Blue
    {
        private (char, double)[] _output;
        public (char, double)[] Output
        {
            get
            {
                if (_output == null) return null;

                (char, double)[] copy = new (char, double)[_output.Length];
                Array.Copy(_output, copy, _output.Length);
                return copy;
            }
        }
        public Blue_3(string input ) : base(input)
        {
            _output = null;

        }

        public override void Review()
        {
            if (string.IsNullOrEmpty(_input))
            {
                _output = null;
                return;
            }

            //var text = _input.Split(' ');
            var text = _input.Split(new[] { ' ', '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' }, StringSplitOptions.RemoveEmptyEntries);
            //var ninput = _input.Replace(" " , "  ");
            //var text2 = ninput.Split(' ');
            string unique = "";
            foreach (string word in text)
            {
                if (string.IsNullOrEmpty(word)) continue;
                char c = char.ToLower(word[0]);
                if (!unique.Contains(c)&&char.IsLetter(c)) unique += c;
            }
            (char letter, int count)[] counts = new (char, int)[unique.Length];
            for (int i = 0; i < unique.Length; i++)
            {
                counts[i].letter = unique[i];
                counts[i].count = 0;
            }
            foreach (string word in text)
            {
                if (string.IsNullOrEmpty(word)) continue;
                char first = char.ToLower(word[0]);
                for (int i = 0; i < counts.Length; i++)
                {
                    if (counts[i].letter == first)
                    {
                        counts[i].count++;
                        break;
                    }
                }
            }

            for (int i = 0; i < counts.Length; i++)
            {
                for (int j = 0; j < counts.Length - 1; j++)
                {
                    if( (counts[j].count < counts[j + 1].count) || (counts[j].count == counts[j + 1].count && counts[j].letter > counts[j + 1].letter) )
                    {
                        (counts[j], counts[j + 1]) = (counts[j + 1], counts[j]);
                    } 
                }
            }
            //double per = 0.0;
            (char, double)[] res = new (char, double)[counts.Length];
            for (int i = 0; i < counts.Length; i++)
            {
                 //per = counts[i].count / text.Length;
                res[i] = (counts[i].letter,(double)counts[i].count / text.Length * 100);
            }
            _output = res;

            

        }
        public override string ToString()
        {
            if (_output == null) return null;
            string res = "";
            for (int i = 0; i < _output.Length ; i++)
            {
                res += $"{_output[i].Item1} - {_output[i].Item2:f4}";
                if (i < _output.Length - 1)
                {
                    res+=Environment.NewLine;
                }
            }
            //res += $"{_output[_output.Length - 1].Item1} - {_output[_output.Length - 1].Item2:f4}\n";
            //foreach (var v in _output)
            //{
            //    res += $"{v.Item1} - {v.Item2:F4}  \n";
            //}
            //return res.TrimEnd('\n');
            //string res = "";
            //foreach (var v in _output)
            //{
            //    res += $"{v.Item1} - {v.Item2:F4} \n";
            //}
            return res.TrimEnd('\n');
           
        }



    }  

}
