using DatReaderWriter.Types;
foreach (var f in typeof(VertexArray).GetFields(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public))
    Console.WriteLine("field " + f.Name + " -> " + f.FieldType.FullName);
foreach (var p in typeof(VertexArray).GetProperties())
    Console.WriteLine("prop " + p.Name + " -> " + p.PropertyType.FullName);
