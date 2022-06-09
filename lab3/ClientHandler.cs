namespace lab3;

public abstract class ClientHandler {
    public ClientFactory ClientFactory;

    public abstract Client CreateClient(string clientType, string userName);
}
