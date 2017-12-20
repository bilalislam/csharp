// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// NodeSystemInfo is a set of ids/uuids to uniquely identify the node.
    /// </summary>
    public partial class V1NodeSystemInfo
    {
        /// <summary>
        /// Initializes a new instance of the V1NodeSystemInfo class.
        /// </summary>
        public V1NodeSystemInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1NodeSystemInfo class.
        /// </summary>
        /// <param name="architecture">The Architecture reported by the
        /// node</param>
        /// <param name="bootID">Boot ID reported by the node.</param>
        /// <param name="containerRuntimeVersion">ContainerRuntime Version
        /// reported by the node through runtime remote API (e.g.
        /// docker://1.5.0).</param>
        /// <param name="kernelVersion">Kernel Version reported by the node
        /// from 'uname -r' (e.g. 3.16.0-0.bpo.4-amd64).</param>
        /// <param name="kubeProxyVersion">KubeProxy Version reported by the
        /// node.</param>
        /// <param name="kubeletVersion">Kubelet Version reported by the
        /// node.</param>
        /// <param name="machineID">MachineID reported by the node. For unique
        /// machine identification in the cluster this field is preferred.
        /// Learn more from man(5) machine-id:
        /// http://man7.org/linux/man-pages/man5/machine-id.5.html</param>
        /// <param name="operatingSystem">The Operating System reported by the
        /// node</param>
        /// <param name="osImage">OS Image reported by the node from
        /// /etc/os-release (e.g. Debian GNU/Linux 7 (wheezy)).</param>
        /// <param name="systemUUID">SystemUUID reported by the node. For
        /// unique machine identification MachineID is preferred. This field is
        /// specific to Red Hat hosts
        /// https://access.redhat.com/documentation/en-US/Red_Hat_Subscription_Management/1/html/RHSM/getting-system-uuid.html</param>
        public V1NodeSystemInfo(string architecture, string bootID, string containerRuntimeVersion, string kernelVersion, string kubeProxyVersion, string kubeletVersion, string machineID, string operatingSystem, string osImage, string systemUUID)
        {
            Architecture = architecture;
            BootID = bootID;
            ContainerRuntimeVersion = containerRuntimeVersion;
            KernelVersion = kernelVersion;
            KubeProxyVersion = kubeProxyVersion;
            KubeletVersion = kubeletVersion;
            MachineID = machineID;
            OperatingSystem = operatingSystem;
            OsImage = osImage;
            SystemUUID = systemUUID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Architecture reported by the node
        /// </summary>
        [JsonProperty(PropertyName = "architecture")]
        public string Architecture { get; set; }

        /// <summary>
        /// Gets or sets boot ID reported by the node.
        /// </summary>
        [JsonProperty(PropertyName = "bootID")]
        public string BootID { get; set; }

        /// <summary>
        /// Gets or sets containerRuntime Version reported by the node through
        /// runtime remote API (e.g. docker://1.5.0).
        /// </summary>
        [JsonProperty(PropertyName = "containerRuntimeVersion")]
        public string ContainerRuntimeVersion { get; set; }

        /// <summary>
        /// Gets or sets kernel Version reported by the node from 'uname -r'
        /// (e.g. 3.16.0-0.bpo.4-amd64).
        /// </summary>
        [JsonProperty(PropertyName = "kernelVersion")]
        public string KernelVersion { get; set; }

        /// <summary>
        /// Gets or sets kubeProxy Version reported by the node.
        /// </summary>
        [JsonProperty(PropertyName = "kubeProxyVersion")]
        public string KubeProxyVersion { get; set; }

        /// <summary>
        /// Gets or sets kubelet Version reported by the node.
        /// </summary>
        [JsonProperty(PropertyName = "kubeletVersion")]
        public string KubeletVersion { get; set; }

        /// <summary>
        /// Gets or sets machineID reported by the node. For unique machine
        /// identification in the cluster this field is preferred. Learn more
        /// from man(5) machine-id:
        /// http://man7.org/linux/man-pages/man5/machine-id.5.html
        /// </summary>
        [JsonProperty(PropertyName = "machineID")]
        public string MachineID { get; set; }

        /// <summary>
        /// Gets or sets the Operating System reported by the node
        /// </summary>
        [JsonProperty(PropertyName = "operatingSystem")]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Gets or sets OS Image reported by the node from /etc/os-release
        /// (e.g. Debian GNU/Linux 7 (wheezy)).
        /// </summary>
        [JsonProperty(PropertyName = "osImage")]
        public string OsImage { get; set; }

        /// <summary>
        /// Gets or sets systemUUID reported by the node. For unique machine
        /// identification MachineID is preferred. This field is specific to
        /// Red Hat hosts
        /// https://access.redhat.com/documentation/en-US/Red_Hat_Subscription_Management/1/html/RHSM/getting-system-uuid.html
        /// </summary>
        [JsonProperty(PropertyName = "systemUUID")]
        public string SystemUUID { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Architecture == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Architecture");
            }
            if (BootID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BootID");
            }
            if (ContainerRuntimeVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContainerRuntimeVersion");
            }
            if (KernelVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KernelVersion");
            }
            if (KubeProxyVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KubeProxyVersion");
            }
            if (KubeletVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KubeletVersion");
            }
            if (MachineID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MachineID");
            }
            if (OperatingSystem == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OperatingSystem");
            }
            if (OsImage == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OsImage");
            }
            if (SystemUUID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SystemUUID");
            }
        }
    }
}