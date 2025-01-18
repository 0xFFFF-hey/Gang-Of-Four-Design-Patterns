using DesignPatterns.Memento;

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
Console.WriteLine("After Undo 2: " + editor.Content);