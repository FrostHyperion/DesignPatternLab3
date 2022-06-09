namespace lab3;

public class Admin : Client {
    private string _userName;
    private string _authUserString;
    private bool _hasAccess;

    public string UserName { get => _userName; set => _userName = value; }
    public string AuthUserString { get => _authUserString; set => _authUserString = value; }
    public bool HasAccess { get => _hasAccess; set => _hasAccess = value; }

    public Admin(string userName) {
        _userName = userName;
        _hasAccess = true;
    }

    public string BuildAuthString() {
        _authUserString = "ncidasnssASDJASDFAcadfasf/adssd" + "ADMIN";
        return _authUserString;
    }
}
