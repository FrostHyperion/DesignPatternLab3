namespace lab3;

public abstract class ClientFactory {
    public ClientFactory(string clientType, string userName) {
        CreateClient(clientType, userName);
    }
    public Client CreateClient(string clientType, string userName) {
        Client client = null;
        if (clientType == "admin") {
            client = new Admin(userName);
        }
        if (clientType == "user") {
            client = new User(userName);
        }
        if (clientType == "manager") {
            client = new Manager(userName);
        }
        client.BuildAuthString();
        return client;
    }
}
