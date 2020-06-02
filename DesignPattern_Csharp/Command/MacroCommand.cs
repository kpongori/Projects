using System.Collections.Generic;

namespace Command
{
    public class MacroCommand : ICommand
    {
        private Stack<ICommand> commands = new Stack<ICommand> ();

        public void Execute ()
        {
            foreach (var command in commands)
            {
                command.Execute ();
            }
        }
        public void Append (ICommand command)
        {
            if (command != this)
            {
                commands.Push (command);
            }
        }
        public void Undo ()
        {
            if (commands.Count != 0)
            {
                commands.Pop ();
            }
        }
        public void Clear ()
        {
            commands.Clear ();
        }
    }
}