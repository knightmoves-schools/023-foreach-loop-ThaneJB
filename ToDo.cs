namespace knightmoves;
public class ToDo
{
    // Add your code here
    public string[] MarkAsDone(string[] todos){
        
        int i = 0;

        foreach(string todo in todos){
            todos[i] = "done - " + todo;
            i++;
        }
            return todos;
    } 
}
