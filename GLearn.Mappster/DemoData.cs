using Mapster;

namespace GLearn.Mappster;
[AdaptTo("[name]Dto"), GenerateMapper]
public class DemoData
{
	public string Data1 { get; set; } = string.Empty;
	public string Data2 { get; set; } = string.Empty;
	public string Data3 { get; set; } = string.Empty;
	public string Data4 { get; set; } = string.Empty;
}	
