namespace lab3;

public interface Client {
    public string UserName { get; set; }
    public string AuthUserString { get; set; }
    bool HasAccess { get; set; }
    string BuildAuthString();
}
