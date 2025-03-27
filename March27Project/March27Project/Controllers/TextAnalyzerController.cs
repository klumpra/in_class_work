using March27Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March27Project.Controllers {
    public class TextAnalyzerController {
        public string ReadStory(string path) {
            string text;
            try {
                using (StreamReader sr = new StreamReader(path)) {
                    text = sr.ReadToEnd();
                }
                return text;
            }
            catch (Exception ex) {
                return string.Empty;
            }
        }
        public bool SaveStory(string path, string text) {
            try {
                using (StreamWriter sw = new StreamWriter(path)) {
                    sw.WriteLine(text);
                }
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
        public List<WordCount> AnalyzeText(string text, string sortBy = "word") {
            text = text.Replace('\n', ' ').Replace('"', ' ').Replace('(',' ').Replace(')',' ');
            sortBy = sortBy.ToLower();
            string[] parts = text.Split(new char[] { '.', ',', ';', ':', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> analysis = new Dictionary<string, int>();
            foreach (string part in parts) {
                string word = part.ToLower();
                if (analysis.ContainsKey(word)) {
                    analysis[word] = analysis[word] + 1;
                } else {
                    analysis[word] = 1;
                }
            }
            List<WordCount> results = new List<WordCount>();
            foreach (var entry in analysis) {
                results.Add(new WordCount(entry.Key, entry.Value));
            }
            if (sortBy == "word") {
                return results.OrderBy(wc => wc.Word).ToList(); // sort WordCounts by the word in alpha order
            } else { // sort by count in descending order
                return results.OrderByDescending(wc => wc.Count).ToList();
            }
        }
        public bool SaveAnalysis(string path, List<WordCount> wordCounts) {
            // grab the extension of the path
            string extension = Path.GetExtension(path); // .txt, .xml, .json
            WordCountWriter wcw = new WordCountWriter();
            if (extension == ".txt") {
                return wcw.WriteText(wordCounts, path);
            } else if (extension == ".xml") {
                return wcw.WriteXML(wordCounts, path);
            } else if (extension == ".json") {
                return wcw.WriteJson(wordCounts, path);
            } else {
                return false;
            }
        }
    }
}
