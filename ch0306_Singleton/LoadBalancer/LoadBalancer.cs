using System;
using System.Collections;
using System.Threading;

namespace LoadBalancer
{
    class LoadBalancer
    {
        private static LoadBalancer balancer;
        private ArrayList servers = new ArrayList();
        private Random random = new Random();
        protected LoadBalancer()
        {
            servers.Add("Server I");
            servers.Add("Server II");
            servers.Add("Server III");
            servers.Add("Server IV");
            servers.Add("Server V");
        }
        public static LoadBalancer GetLoadBalancer()
        {
            if (balancer == null)
            {
                Mutex mutex = new Mutex();
                mutex.WaitOne();
                if (balancer == null)
                    balancer = new LoadBalancer();
                mutex.Close();
            }
            return balancer;
        }
        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }
    }
}
