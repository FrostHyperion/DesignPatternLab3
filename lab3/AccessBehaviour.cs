namespace lab3;

public interface AccessBehaviour {
    public Client Client { get; set; }
    public bool HandleAccess();
}
