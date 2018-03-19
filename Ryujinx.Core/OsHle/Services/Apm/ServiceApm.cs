using Ryujinx.Core.OsHle.Ipc;
using System.Collections.Generic;

namespace Ryujinx.Core.OsHle.IpcServices.Apm
{
    class ServiceApm : IpcService
    {
        private Dictionary<int, ServiceProcessRequest> m_Commands;

        public override IReadOnlyDictionary<int, ServiceProcessRequest> Commands => m_Commands;

        public ServiceApm()
        {
            m_Commands = new Dictionary<int, ServiceProcessRequest>()
            {
                { 0, OpenSession }
            };
        }

        public long OpenSession(ServiceCtx Context)
        {
            MakeObject(Context, new ISession());

            return 0;
        }
    }
}