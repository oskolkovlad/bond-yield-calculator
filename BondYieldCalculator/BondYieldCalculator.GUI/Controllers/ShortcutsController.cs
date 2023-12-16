namespace BondYieldCalculator.GUI.Controllers
{
    using System;
    using System.Windows.Forms;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.ViewControls;

    internal class ShortcutsController : IShortcutsController
    {
        public ShortcutsController(IShortcutsForm shortcutsForm)
        {
            shortcutsForm.KeyDown += (sender, args) => HandleFormKeyDown(args);
            shortcutsForm.LinksShortcutsView.LinkTextBoxKeyDown += (sender, args) => HandleLinkTextBoxKeyDown(args);
        }

        public event EventHandler LinkAdding = delegate { };

        public event EventHandler LinksRemoving = delegate { };

        public event EventHandler LinksAnalyzing = delegate { };

        public event EventHandler LinksRestoring = delegate { };

        public event EventHandler LinksSaving = delegate { };

        private void HandleFormKeyDown(KeyEventArgs args)
        {
            switch (args.KeyCode)
            {
                case Keys.Insert:
                    LinkAdding?.Invoke(this, EventArgs.Empty);
                    break;

                case Keys.Delete:
                    LinksRemoving?.Invoke(this, EventArgs.Empty);
                    break;

                case Keys.A:
                    if (args.Control)
                    {
                        LinksAnalyzing?.Invoke(this, EventArgs.Empty);
                    }
                    break;

                case Keys.R:
                    if (args.Control)
                    {
                        LinksRestoring?.Invoke(this, EventArgs.Empty);
                    }
                    break;

                case Keys.S:
                    if (args.Control)
                    {
                        LinksSaving?.Invoke(this, EventArgs.Empty);
                    }
                    break;
            }
        }

        private void HandleLinkTextBoxKeyDown(KeyEventArgs args)
        {
            if (args.KeyCode == Keys.Enter)
            {
                LinkAdding?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
