using System;
using System.Windows.Forms;
using DevExpress.XtraEditors.DXErrorProvider;

namespace ValidationProviderSuccessEvent
{
    public class MyValidationProvider : DXValidationProvider
    {
        public event ControlValidationSuccededEventHandler ControlValidationSucceded;
        public event ValidationSuccessfullyCompleteEventHandler ValidationSuccessfullyComplete;

        public override void RemoveControlError(Control control)
        {
            base.RemoveControlError(control);

            RaiseControlValidationSucceded(new ControlValidationSuccededEventArgs(control));
            if ( this.GetInvalidControls().Count == 0 )
                RaiseValidationSuccessfullyComplete();
        }

        public void RaiseControlValidationSucceded(ControlValidationSuccededEventArgs e)
        {
            if ( ControlValidationSucceded != null )
                ControlValidationSucceded(this, e);
        }

        public void RaiseValidationSuccessfullyComplete()
        {
            if ( ValidationSuccessfullyComplete != null )
                ValidationSuccessfullyComplete(this, new EventArgs());
        }
    }

    public delegate void ControlValidationSuccededEventHandler(object sender, ControlValidationSuccededEventArgs e);
    public delegate void ValidationSuccessfullyCompleteEventHandler(object sender, EventArgs e);

    public class ControlValidationSuccededEventArgs : EventArgs
    {
        Control control;

        public ControlValidationSuccededEventArgs(Control control)
        {
            this.control = control;
        }

        public Control ValidControl
        {
            get { return control; }
        }
    }
}
