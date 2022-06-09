namespace lab3;

public class SwitchAuth : AccessBehaviour {
    private Client _client;
    public Client Client { get => _client; set => _client = value; }

    public SwitchAuth(Client client) {
        _client = client;
    }

    public bool HandleAccess() {
        var hasAccess = _client.HasAccess;
        _client.HasAccess = !_client.HasAccess;
        return hasAccess;
    }
}
