namespace lab3;

public class RetailClientHanlder : ClientHandler {
    public override Client CreateClient(string clientType, string userName) {
        var client = ClientFactory.CreateClient(clientType, userName);
        return client;
    }
}
