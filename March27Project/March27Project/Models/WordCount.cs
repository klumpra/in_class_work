using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace March27Project.Models {
    [Serializable]
    public class WordCount {
        public string Word { get; set; }
        private int count;
        public int Count {
            get { return count; }
            set {
                if (value < 0) {
                    count = 0;
                }
                else {
                    count = value;
                }
            }
        }
        public WordCount() {
            Word = string.Empty;
            Count = 0;
        }
        public WordCount(string word) {
            Word = word;
            Count = 0;
        }
        public WordCount(string word, int count) {
            Word = word;
            Count = count;
        }
        public override string ToString() {
            return $"{Word}\t{Count}";
        }
    }
}
