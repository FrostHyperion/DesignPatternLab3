namespace lab3;

public class EnterPriseClientHanlder : ClientHandler {
    public override Client CreateClient(string clientType, string userName) {
        var client = ClientFactory.CreateClient(clientType, userName);
        AccessBehaviour access = null;
        if (clientType == "admin") {
            access = new CheckString(client);
        }
        if (clientType == "user") {
            access = new SwitchAuth(client);
        }
        if (clientType == "manager") {
            access = new SwitchAuth(client);
        }
        return client;
    }
}
