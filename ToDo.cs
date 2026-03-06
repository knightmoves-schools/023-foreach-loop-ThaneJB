namespace knightmoves;
public class ToDo
{
    // Add your code here
    public string[] MarkAsDone(string[] todos){
        foreach(string todo in todos){
            string todo = "done - " + todos;
        }
            return todos;
    }
}
