namespace DesignPatterns.Behavioral.State
{
    internal class Document
    {
        public State State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public Document(UserRoles currentUserRole)
        {
            State = new DraftState(this); // New documents have draft state by default
            CurrentUserRole = currentUserRole;
        }

        public void Publish()
        {
            State.Publish();
        }
    }
}
