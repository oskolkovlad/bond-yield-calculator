namespace BondYieldCalculator.GUI.ViewControls
{
    internal static class ViewHelper
    {
        public static void InvokeIfRequired(this Control control, Action action)
        {
            if (control is null)
            {
                return;
            }

            if (control.InvokeRequired)
            {
                control.BeginInvoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
