using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace March27Project.Models {
    public class WordCountWriter {
        public bool WriteText(List<WordCount> wordCounts, string path) {
            try {
                using (StreamWriter sw = new StreamWriter(path)) {
                    foreach (WordCount wc in wordCounts) {
                        sw.WriteLine(wc);
                    }
                }
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
        public bool WriteXML(List<WordCount> wordCounts, string path) {
            try {
                DataSerializer ds = new DataSerializer();
                ds.XmlSerialize<List<WordCount>>(wordCounts, path);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
        public bool WriteJson(List<WordCount> wordCounts, string path) {
            try {
                DataSerializer ds = new DataSerializer();
                ds.JsonSerialize<List<WordCount>>(wordCounts, path);    
                return true;
            } catch (Exception ex) {
                return false;
            }
        }
    }
}
