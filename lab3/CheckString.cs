namespace lab3;

public class CheckString : AccessBehaviour {
    private Client _client;
    public Client Client { get => _client; set => _client = value; }

    public CheckString(Client client) {
        _client = client;
    }

    public bool HandleAccess() {
        _client.HasAccess = _client.AuthUserString.Contains("ADMIN");
        return _client.HasAccess;
    }
}
