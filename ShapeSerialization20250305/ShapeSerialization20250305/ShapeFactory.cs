using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSerialization20250305
{
    internal class ShapeFactory
    {
        public Dictionary<string, Shape> builders;
        public void InitializeBuilders()
        {
            builders.Add("circle", new Circle());
            builders.Add("rectangle", new Rectangle());
        }
        public ShapeFactory()
        {
            builders = new Dictionary<string, Shape>();
            InitializeBuilders();
        }
        public void RegisterBuilder(string key, Shape builder)
        {
            builders.Add(key, builder);
        }
        // desc is a tab-delimited string
        // the first entry in desc is the shape type
        // the shape type is used as index to identifier the corresponding builder from builders
        public Shape BuildShape(string desc)
        {
            try
            {
                desc = desc.ToLower().Trim();
                string key = desc.Split("\t")[0];
                if (builders.ContainsKey(key))
                {
                    return builders[key].CreateShape(desc);
                } else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
