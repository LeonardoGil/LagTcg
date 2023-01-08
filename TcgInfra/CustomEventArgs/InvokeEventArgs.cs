namespace TcgInfra.CustomEventArgs
{ 
    public class InvokeEventArgs : EventArgs
    {
        public int Position { get; set; }

        public bool Set { get; set; }
    }
}
