using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LIB
{
    public class BaseRepository<Entity>
    {
        public int uniqueId = 1;
        protected List<Entity> entities = [];
        public void Create(Entity entity)
        {
            entities.Add(entity);
        }
        public Entity Get(int index)
        {
            return entities[index];
        }
        public void Reset()
        {
            entities.Clear();
        }
        public void Update(Entity newEntity, int index)
        {
            for (int i = 0; i < entities.Count; i++)
            {
                entities[i] = newEntity;
            }
        }
        public void Delete(int index)
        {
            entities.RemoveAt(index);
        }
        public void Show()
        {
            foreach (Entity entity in entities)
            {
                FieldInfo[] fields = typeof(Entity).GetFields();
                foreach (FieldInfo field in fields)
                {
                    var value = field.GetValue(entity);
                    Console.Write($"{field.Name}: {value}\t");
                }
                Console.WriteLine();
            }
        }
        public int Count()
        {
            return entities.Count;
        }
    }

    // The "S" in CRUD means "Save", so it's also saving and fetching data from .txt
    public class Repository<Entity> : BaseRepository<Entity>
    {
        protected string dbPath;
        private char delimiter = ',';
        public Repository(string path, char delimiter = ',')
        {
            this.delimiter = delimiter;
            dbPath = path + typeof(Entity).Name + ".txt";
            Fetch();
        }
        public void Save()
        {
            string contents = "";
            foreach (Entity entity in entities)
            {
                FieldInfo[] fields = typeof(Entity).GetFields();
                for (int i = 0; i < fields.Count(); i++)
                {
                    FieldInfo field = fields[i];
                    var value = field.GetValue(entity);
                    string valueStringified = value.ToString();
                    contents += valueStringified;
                    if (i != fields.Count() - 1)
                    {
                        contents += delimiter;
                    }
                }
                contents += "\n";
            }
            File.WriteAllText(dbPath, contents);
        }
        public void Fetch()
        {
            FieldInfo[] fields = typeof(Entity).GetFields();
            foreach (string content in File.ReadAllLines(dbPath))
            {
                string[] rawValues = content.Split(delimiter);
                if (rawValues.Length != fields.Length)
                {
                    continue;
                }
                Entity entity = Activator.CreateInstance<Entity>();
                for (int i = 0; i < rawValues.Length; i++)
                {
                    string rawValue = rawValues[i];
                    Type fieldType = fields[i].FieldType;
                    try
                    {
                        object convertedValue = Convert.ChangeType(rawValue, fieldType);
                        fields[i].SetValue(entity, convertedValue);
                    }
                    catch (InvalidCastException)
                    {
                        continue;
                    }
                }
                Create(entity);
            }
        }
    }
}