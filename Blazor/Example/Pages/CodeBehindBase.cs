using Microsoft.AspNetCore.Components;

namespace Example.Pages{
public class CodeBehindBase : ComponentBase{

    protected string header { get; set; } = "My Header";
    protected string headerToBe;
    
    protected void UpdateHeader() {
        header = headerToBe;
    }

}
}