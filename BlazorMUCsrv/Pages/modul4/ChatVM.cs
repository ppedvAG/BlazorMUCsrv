using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMUCsrv.Pages.modul4
{
    public class ChatVM
    {
        //public Action onAdd;
        public event EventHandler onAdd;
        public List<ChatNachricht> ChatListe { get; private set; } = new List<ChatNachricht>();
        public void Add(string msg)
        {
            ChatListe.Add(new ChatNachricht { Message = msg });
            onAdd.Invoke(null,null);
        }
    }
}
