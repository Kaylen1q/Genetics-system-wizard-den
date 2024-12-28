using Content.Client.DNA.UI;
using Content.Shared.DNA;
using JetBrains.Annotations;
using Content.Shared.Cloning.CloningConsole;
using Robust.Client.UserInterface;



namespace Content.Client.DNA
{
    [UsedImplicitly]
    public sealed class DNAConsoleBoundUserInterface : BoundUserInterface
    {
        [ViewVariables]
        private DNAConsoleWindow? _window;

        public DNAConsoleBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
        {
        }

        protected override void Open()
        {
            base.Open();

            _window = this.CreateWindow<DNAConsoleWindow>();
            _window.Title = Loc.GetString("cloning-console-window-title");

            
        }

        protected override void UpdateState(BoundUserInterfaceState state)
        {
            base.UpdateState(state);

            _window?.Populate((DNAConsoleBoundUserInterfaceState)state);
        }
    }
}

