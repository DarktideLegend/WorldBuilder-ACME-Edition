using DatReaderWriter.Enums;
using DatReaderWriter.Types;

foreach (var n in Enum.GetNames(typeof(VertexType)))
    Console.WriteLine("VertexType." + n);
foreach (var n in Enum.GetNames(typeof(CullMode)))
    Console.WriteLine("CullMode." + n);
