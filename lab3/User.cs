namespace lab3;

public class User : Client {
    private string _userName;
    private string _authUserString;
    private bool _hasAccess;

    public string UserName { get => _userName; set => _userName = value; }
    public string AuthUserString { get => _authUserString; set => _authUserString = value; }
    public bool HasAccess { get => _hasAccess; set => _hasAccess = value; }

    public User(string userName) {
        _userName = userName;
        HasAccess = false;
    }

    public string BuildAuthString() {
        _authUserString = _userName;
        return _authUserString;
    }
}
