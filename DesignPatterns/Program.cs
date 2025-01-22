
#region MementoDP
/*using DesignPatterns.Memento;

var editor = new Editor();
var history = new History();

editor.Write("Hello");
history.Save(editor.Save());

editor.Write(", World!");
history.Save(editor.Save());

editor.Write(" This is the Memento pattern.");
Console.WriteLine("Current Content: " + editor.Content);

editor.Restore(history.Undo());
Console.WriteLine("After Undo 1: " + editor.Content);

editor.Restore(history.Undo());
Console.WriteLine("After Undo 2: " + editor.Content);*/
#endregion

#region StateDP
/*using DesignPatterns.Behavioral.State;

var document = new Document(UserRoles.EDITOR);

Console.WriteLine("Current State: Draft");
document.Publish();

Console.WriteLine("Current State: Moderation");
document.CurrentUserRole = UserRoles.ADMIN;
document.Publish(); 

Console.WriteLine("Current State: Published");
document.Publish(); */
#endregion

#region Visitor
using DesignPatterns.Behavioral.Visitor.GoodExample;
var clients = new List<Client>() {
    new Restaurant("Resto", "resto@gmail.com"),
    new Retail("Retail", "retail@hotmail.fr"),
    new Law("law", "law@mail.com")
};
foreach (var client in clients)
{
    client.Accept(new EmailVisitor());
    client.Accept(new PDFExportVisitor());
}
#endregion