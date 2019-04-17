using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Common.Events
{
    [/*Attribute with token 0C000041*/CompilerGenerated]
    [/*Attribute with token 0C000042*/DebuggerNonUserCode]
    [/*Attribute with token 0C000043*/GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    internal class Resources
    {
        // Field resourceMan with token 04000078
        private static ResourceManager resourceMan;
        // Field resourceCulture with token 04000079
        private static CultureInfo resourceCulture;

        // Property ResourceManager with token 1700004E
        [/*Attribute with token 0C00004C*/EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            // Method get_ResourceManager with token 060001D5
            get
            {
                if (object.ReferenceEquals((object)Resources.resourceMan, (object)null))
                    Resources.resourceMan = new ResourceManager("Microsoft.Practices.Prism.Properties.Resources", typeof(Resources).Assembly);
                return Resources.resourceMan;
            }
        }

        // Property Culture with token 1700004F
        [/*Attribute with token 0C00004F*/EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            // Method get_Culture with token 060001D6
            get
            {
                return Resources.resourceCulture;
            }
            // Method set_Culture with token 060001D7
            set
            {
                Resources.resourceCulture = value;
            }
        }

        // Property AdapterInvalidTypeException with token 17000050
        internal static string AdapterInvalidTypeException
        {
            // Method get_AdapterInvalidTypeException with token 060001D8
            get
            {
                return Resources.ResourceManager.GetString("AdapterInvalidTypeException", Resources.resourceCulture);
            }
        }

        // Property CannotChangeRegionNameException with token 17000051
        internal static string CannotChangeRegionNameException
        {
            // Method get_CannotChangeRegionNameException with token 060001D9
            get
            {
                return Resources.ResourceManager.GetString("CannotChangeRegionNameException", Resources.resourceCulture);
            }
        }

        // Property CannotCreateNavigationTarget with token 17000052
        internal static string CannotCreateNavigationTarget
        {
            // Method get_CannotCreateNavigationTarget with token 060001DA
            get
            {
                return Resources.ResourceManager.GetString("CannotCreateNavigationTarget", Resources.resourceCulture);
            }
        }

        // Property CannotRegisterCompositeCommandInItself with token 17000053
        internal static string CannotRegisterCompositeCommandInItself
        {
            // Method get_CannotRegisterCompositeCommandInItself with token 060001DB
            get
            {
                return Resources.ResourceManager.GetString("CannotRegisterCompositeCommandInItself", Resources.resourceCulture);
            }
        }

        // Property CannotRegisterSameCommandTwice with token 17000054
        internal static string CannotRegisterSameCommandTwice
        {
            // Method get_CannotRegisterSameCommandTwice with token 060001DC
            get
            {
                return Resources.ResourceManager.GetString("CannotRegisterSameCommandTwice", Resources.resourceCulture);
            }
        }

        // Property CanOnlyAddTypesThatInheritIFromRegionBehavior with token 17000055
        internal static string CanOnlyAddTypesThatInheritIFromRegionBehavior
        {
            // Method get_CanOnlyAddTypesThatInheritIFromRegionBehavior with token 060001DD
            get
            {
                return Resources.ResourceManager.GetString("CanOnlyAddTypesThatInheritIFromRegionBehavior", Resources.resourceCulture);
            }
        }

        // Property ConfigurationStoreCannotBeNull with token 17000056
        internal static string ConfigurationStoreCannotBeNull
        {
            // Method get_ConfigurationStoreCannotBeNull with token 060001DE
            get
            {
                return Resources.ResourceManager.GetString("ConfigurationStoreCannotBeNull", Resources.resourceCulture);
            }
        }

        // Property ContentControlHasContentException with token 17000057
        internal static string ContentControlHasContentException
        {
            // Method get_ContentControlHasContentException with token 060001DF
            get
            {
                return Resources.ResourceManager.GetString("ContentControlHasContentException", Resources.resourceCulture);
            }
        }

        // Property CyclicDependencyFound with token 17000058
        internal static string CyclicDependencyFound
        {
            // Method get_CyclicDependencyFound with token 060001E0
            get
            {
                return Resources.ResourceManager.GetString("CyclicDependencyFound", Resources.resourceCulture);
            }
        }

        // Property DeactiveNotPossibleException with token 17000059
        internal static string DeactiveNotPossibleException
        {
            // Method get_DeactiveNotPossibleException with token 060001E1
            get
            {
                return Resources.ResourceManager.GetString("DeactiveNotPossibleException", Resources.resourceCulture);
            }
        }

        // Property DefaultTextLoggerPattern with token 1700005A
        internal static string DefaultTextLoggerPattern
        {
            // Method get_DefaultTextLoggerPattern with token 060001E2
            get
            {
                return Resources.ResourceManager.GetString("DefaultTextLoggerPattern", Resources.resourceCulture);
            }
        }

        // Property DelegateCommandDelegatesCannotBeNull with token 1700005B
        internal static string DelegateCommandDelegatesCannotBeNull
        {
            // Method get_DelegateCommandDelegatesCannotBeNull with token 060001E3
            get
            {
                return Resources.ResourceManager.GetString("DelegateCommandDelegatesCannotBeNull", Resources.resourceCulture);
            }
        }

        // Property DelegateCommandInvalidGenericPayloadType with token 1700005C
        internal static string DelegateCommandInvalidGenericPayloadType
        {
            // Method get_DelegateCommandInvalidGenericPayloadType with token 060001E4
            get
            {
                return Resources.ResourceManager.GetString("DelegateCommandInvalidGenericPayloadType", Resources.resourceCulture);
            }
        }

        // Property DependencyForUnknownModule with token 1700005D
        internal static string DependencyForUnknownModule
        {
            // Method get_DependencyForUnknownModule with token 060001E5
            get
            {
                return Resources.ResourceManager.GetString("DependencyForUnknownModule", Resources.resourceCulture);
            }
        }

        // Property DependencyOnMissingModule with token 1700005E
        internal static string DependencyOnMissingModule
        {
            // Method get_DependencyOnMissingModule with token 060001E6
            get
            {
                return Resources.ResourceManager.GetString("DependencyOnMissingModule", Resources.resourceCulture);
            }
        }

        // Property DirectoryNotFound with token 1700005F
        internal static string DirectoryNotFound
        {
            // Method get_DirectoryNotFound with token 060001E7
            get
            {
                return Resources.ResourceManager.GetString("DirectoryNotFound", Resources.resourceCulture);
            }
        }

        // Property DuplicatedModule with token 17000060
        internal static string DuplicatedModule
        {
            // Method get_DuplicatedModule with token 060001E8
            get
            {
                return Resources.ResourceManager.GetString("DuplicatedModule", Resources.resourceCulture);
            }
        }

        // Property DuplicatedModuleGroup with token 17000061
        internal static string DuplicatedModuleGroup
        {
            // Method get_DuplicatedModuleGroup with token 060001E9
            get
            {
                return Resources.ResourceManager.GetString("DuplicatedModuleGroup", Resources.resourceCulture);
            }
        }

        // Property FailedToGetType with token 17000062
        internal static string FailedToGetType
        {
            // Method get_FailedToGetType with token 060001EA
            get
            {
                return Resources.ResourceManager.GetString("FailedToGetType", Resources.resourceCulture);
            }
        }

        // Property FailedToLoadModule with token 17000063
        internal static string FailedToLoadModule
        {
            // Method get_FailedToLoadModule with token 060001EB
            get
            {
                return Resources.ResourceManager.GetString("FailedToLoadModule", Resources.resourceCulture);
            }
        }

        // Property FailedToLoadModuleNoAssemblyInfo with token 17000064
        internal static string FailedToLoadModuleNoAssemblyInfo
        {
            // Method get_FailedToLoadModuleNoAssemblyInfo with token 060001EC
            get
            {
                return Resources.ResourceManager.GetString("FailedToLoadModuleNoAssemblyInfo", Resources.resourceCulture);
            }
        }

        // Property FailedToRetrieveModule with token 17000065
        internal static string FailedToRetrieveModule
        {
            // Method get_FailedToRetrieveModule with token 060001ED
            get
            {
                return Resources.ResourceManager.GetString("FailedToRetrieveModule", Resources.resourceCulture);
            }
        }

        // Property HostControlCannotBeNull with token 17000066
        internal static string HostControlCannotBeNull
        {
            // Method get_HostControlCannotBeNull with token 060001EE
            get
            {
                return Resources.ResourceManager.GetString("HostControlCannotBeNull", Resources.resourceCulture);
            }
        }

        // Property HostControlCannotBeSetAfterAttach with token 17000067
        internal static string HostControlCannotBeSetAfterAttach
        {
            // Method get_HostControlCannotBeSetAfterAttach with token 060001EF
            get
            {
                return Resources.ResourceManager.GetString("HostControlCannotBeSetAfterAttach", Resources.resourceCulture);
            }
        }

        // Property HostControlMustBeATabControl with token 17000068
        internal static string HostControlMustBeATabControl
        {
            // Method get_HostControlMustBeATabControl with token 060001F0
            get
            {
                return Resources.ResourceManager.GetString("HostControlMustBeATabControl", Resources.resourceCulture);
            }
        }

        // Property IEnumeratorObsolete with token 17000069
        internal static string IEnumeratorObsolete
        {
            // Method get_IEnumeratorObsolete with token 060001F1
            get
            {
                return Resources.ResourceManager.GetString("IEnumeratorObsolete", Resources.resourceCulture);
            }
        }

        // Property InvalidArgumentAssemblyUri with token 1700006A
        internal static string InvalidArgumentAssemblyUri
        {
            // Method get_InvalidArgumentAssemblyUri with token 060001F2
            get
            {
                return Resources.ResourceManager.GetString("InvalidArgumentAssemblyUri", Resources.resourceCulture);
            }
        }

        // Property InvalidDelegateRerefenceTypeException with token 1700006B
        internal static string InvalidDelegateRerefenceTypeException
        {
            // Method get_InvalidDelegateRerefenceTypeException with token 060001F3
            get
            {
                return Resources.ResourceManager.GetString("InvalidDelegateRerefenceTypeException", Resources.resourceCulture);
            }
        }

        // Property ItemsControlHasItemsSourceException with token 1700006C
        internal static string ItemsControlHasItemsSourceException
        {
            // Method get_ItemsControlHasItemsSourceException with token 060001F4
            get
            {
                return Resources.ResourceManager.GetString("ItemsControlHasItemsSourceException", Resources.resourceCulture);
            }
        }

        // Property MappingExistsException with token 1700006D
        internal static string MappingExistsException
        {
            // Method get_MappingExistsException with token 060001F5
            get
            {
                return Resources.ResourceManager.GetString("MappingExistsException", Resources.resourceCulture);
            }
        }

        // Property ModuleDependenciesNotMetInGroup with token 1700006E
        internal static string ModuleDependenciesNotMetInGroup
        {
            // Method get_ModuleDependenciesNotMetInGroup with token 060001F6
            get
            {
                return Resources.ResourceManager.GetString("ModuleDependenciesNotMetInGroup", Resources.resourceCulture);
            }
        }

        // Property ModuleNotFound with token 1700006F
        internal static string ModuleNotFound
        {
            // Method get_ModuleNotFound with token 060001F7
            get
            {
                return Resources.ResourceManager.GetString("ModuleNotFound", Resources.resourceCulture);
            }
        }

        // Property ModulePathCannotBeNullOrEmpty with token 17000070
        internal static string ModulePathCannotBeNullOrEmpty
        {
            // Method get_ModulePathCannotBeNullOrEmpty with token 060001F8
            get
            {
                return Resources.ResourceManager.GetString("ModulePathCannotBeNullOrEmpty", Resources.resourceCulture);
            }
        }

        // Property ModuleTypeNotFound with token 17000071
        internal static string ModuleTypeNotFound
        {
            // Method get_ModuleTypeNotFound with token 060001F9
            get
            {
                return Resources.ResourceManager.GetString("ModuleTypeNotFound", Resources.resourceCulture);
            }
        }

        // Property NavigationInProgress with token 17000072
        internal static string NavigationInProgress
        {
            // Method get_NavigationInProgress with token 060001FA
            get
            {
                return Resources.ResourceManager.GetString("NavigationInProgress", Resources.resourceCulture);
            }
        }

        // Property NavigationServiceHasNoRegion with token 17000073
        internal static string NavigationServiceHasNoRegion
        {
            // Method get_NavigationServiceHasNoRegion with token 060001FB
            get
            {
                return Resources.ResourceManager.GetString("NavigationServiceHasNoRegion", Resources.resourceCulture);
            }
        }

        // Property NoRegionAdapterException with token 17000074
        internal static string NoRegionAdapterException
        {
            // Method get_NoRegionAdapterException with token 060001FC
            get
            {
                return Resources.ResourceManager.GetString("NoRegionAdapterException", Resources.resourceCulture);
            }
        }

        // Property NoRetrieverCanRetrieveModule with token 17000075
        internal static string NoRetrieverCanRetrieveModule
        {
            // Method get_NoRetrieverCanRetrieveModule with token 060001FD
            get
            {
                return Resources.ResourceManager.GetString("NoRetrieverCanRetrieveModule", Resources.resourceCulture);
            }
        }

        // Property OnViewRegisteredException with token 17000076
        internal static string OnViewRegisteredException
        {
            // Method get_OnViewRegisteredException with token 060001FE
            get
            {
                return Resources.ResourceManager.GetString("OnViewRegisteredException", Resources.resourceCulture);
            }
        }

        // Property PropertySupport_ExpressionNotProperty_Exception with token 17000077
        internal static string PropertySupport_ExpressionNotProperty_Exception
        {
            // Method get_PropertySupport_ExpressionNotProperty_Exception with token 060001FF
            get
            {
                return Resources.ResourceManager.GetString("PropertySupport_ExpressionNotProperty_Exception", Resources.resourceCulture);
            }
        }

        // Property PropertySupport_NotMemberAccessExpression_Exception with token 17000078
        internal static string PropertySupport_NotMemberAccessExpression_Exception
        {
            // Method get_PropertySupport_NotMemberAccessExpression_Exception with token 06000200
            get
            {
                return Resources.ResourceManager.GetString("PropertySupport_NotMemberAccessExpression_Exception", Resources.resourceCulture);
            }
        }

        // Property PropertySupport_StaticExpression_Exception with token 17000079
        internal static string PropertySupport_StaticExpression_Exception
        {
            // Method get_PropertySupport_StaticExpression_Exception with token 06000201
            get
            {
                return Resources.ResourceManager.GetString("PropertySupport_StaticExpression_Exception", Resources.resourceCulture);
            }
        }

        // Property RegionBehaviorAttachCannotBeCallWithNullRegion with token 1700007A
        internal static string RegionBehaviorAttachCannotBeCallWithNullRegion
        {
            // Method get_RegionBehaviorAttachCannotBeCallWithNullRegion with token 06000202
            get
            {
                return Resources.ResourceManager.GetString("RegionBehaviorAttachCannotBeCallWithNullRegion", Resources.resourceCulture);
            }
        }

        // Property RegionBehaviorRegionCannotBeSetAfterAttach with token 1700007B
        internal static string RegionBehaviorRegionCannotBeSetAfterAttach
        {
            // Method get_RegionBehaviorRegionCannotBeSetAfterAttach with token 06000203
            get
            {
                return Resources.ResourceManager.GetString("RegionBehaviorRegionCannotBeSetAfterAttach", Resources.resourceCulture);
            }
        }

        // Property RegionCreationException with token 1700007C
        internal static string RegionCreationException
        {
            // Method get_RegionCreationException with token 06000204
            get
            {
                return Resources.ResourceManager.GetString("RegionCreationException", Resources.resourceCulture);
            }
        }

        // Property RegionManagerWithDifferentNameException with token 1700007D
        internal static string RegionManagerWithDifferentNameException
        {
            // Method get_RegionManagerWithDifferentNameException with token 06000205
            get
            {
                return Resources.ResourceManager.GetString("RegionManagerWithDifferentNameException", Resources.resourceCulture);
            }
        }

        // Property RegionNameCannotBeEmptyException with token 1700007E
        internal static string RegionNameCannotBeEmptyException
        {
            // Method get_RegionNameCannotBeEmptyException with token 06000206
            get
            {
                return Resources.ResourceManager.GetString("RegionNameCannotBeEmptyException", Resources.resourceCulture);
            }
        }

        // Property RegionNameExistsException with token 1700007F
        internal static string RegionNameExistsException
        {
            // Method get_RegionNameExistsException with token 06000207
            get
            {
                return Resources.ResourceManager.GetString("RegionNameExistsException", Resources.resourceCulture);
            }
        }

        // Property RegionNotFound with token 17000080
        internal static string RegionNotFound
        {
            // Method get_RegionNotFound with token 06000208
            get
            {
                return Resources.ResourceManager.GetString("RegionNotFound", Resources.resourceCulture);
            }
        }

        // Property RegionNotInRegionManagerException with token 17000081
        internal static string RegionNotInRegionManagerException
        {
            // Method get_RegionNotInRegionManagerException with token 06000209
            get
            {
                return Resources.ResourceManager.GetString("RegionNotInRegionManagerException", Resources.resourceCulture);
            }
        }

        // Property RegionViewExistsException with token 17000082
        internal static string RegionViewExistsException
        {
            // Method get_RegionViewExistsException with token 0600020A
            get
            {
                return Resources.ResourceManager.GetString("RegionViewExistsException", Resources.resourceCulture);
            }
        }

        // Property RegionViewNameExistsException with token 17000083
        internal static string RegionViewNameExistsException
        {
            // Method get_RegionViewNameExistsException with token 0600020B
            get
            {
                return Resources.ResourceManager.GetString("RegionViewNameExistsException", Resources.resourceCulture);
            }
        }

        // Property StartupModuleDependsOnAnOnDemandModule with token 17000084
        internal static string StartupModuleDependsOnAnOnDemandModule
        {
            // Method get_StartupModuleDependsOnAnOnDemandModule with token 0600020C
            get
            {
                return Resources.ResourceManager.GetString("StartupModuleDependsOnAnOnDemandModule", Resources.resourceCulture);
            }
        }

        // Property StringCannotBeNullOrEmpty with token 17000085
        internal static string StringCannotBeNullOrEmpty
        {
            // Method get_StringCannotBeNullOrEmpty with token 0600020D
            get
            {
                return Resources.ResourceManager.GetString("StringCannotBeNullOrEmpty", Resources.resourceCulture);
            }
        }

        // Property StringCannotBeNullOrEmpty1 with token 17000086
        internal static string StringCannotBeNullOrEmpty1
        {
            // Method get_StringCannotBeNullOrEmpty1 with token 0600020E
            get
            {
                return Resources.ResourceManager.GetString("StringCannotBeNullOrEmpty1", Resources.resourceCulture);
            }
        }

        // Property TypeWithKeyNotRegistered with token 17000087
        internal static string TypeWithKeyNotRegistered
        {
            // Method get_TypeWithKeyNotRegistered with token 0600020F
            get
            {
                return Resources.ResourceManager.GetString("TypeWithKeyNotRegistered", Resources.resourceCulture);
            }
        }

        // Property UpdateRegionException with token 17000088
        internal static string UpdateRegionException
        {
            // Method get_UpdateRegionException with token 06000210
            get
            {
                return Resources.ResourceManager.GetString("UpdateRegionException", Resources.resourceCulture);
            }
        }

        // Property ValueMustBeOfTypeModuleInfo with token 17000089
        internal static string ValueMustBeOfTypeModuleInfo
        {
            // Method get_ValueMustBeOfTypeModuleInfo with token 06000211
            get
            {
                return Resources.ResourceManager.GetString("ValueMustBeOfTypeModuleInfo", Resources.resourceCulture);
            }
        }

        // Property ValueNotFound with token 1700008A
        internal static string ValueNotFound
        {
            // Method get_ValueNotFound with token 06000212
            get
            {
                return Resources.ResourceManager.GetString("ValueNotFound", Resources.resourceCulture);
            }
        }

        // Property ViewNotInRegionException with token 1700008B
        internal static string ViewNotInRegionException
        {
            // Method get_ViewNotInRegionException with token 06000213
            get
            {
                return Resources.ResourceManager.GetString("ViewNotInRegionException", Resources.resourceCulture);
            }
        }

        // Method .ctor with token 060001D4
        internal Resources()
        {
        }
    }
}
