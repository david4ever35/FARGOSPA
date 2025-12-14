using FargoSpaAppWellness.Models;

namespace FargoSpaAppWellness.Services
{
    public class UserSession
    {
        public AppUser? CurrentUser { get; private set; }

        public bool IsLoggedIn => CurrentUser != null;

        public bool IsAdmin => CurrentUser?.Role == "Admin";

        // Event that NavMenu can subscribe to
        public event Action? OnChange;

        public void Login(AppUser user)
        {
            CurrentUser = user;
            NotifyStateChanged();
        }

        public void Logout()
        {
            CurrentUser = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}
