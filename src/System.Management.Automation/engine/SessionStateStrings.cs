/********************************************************************++
Copyright (c) Microsoft Corporation.  All rights reserved.
--********************************************************************/

using System;
using System.Management.Automation;
using System.Collections;
using System.IO;


namespace System.Management.Automation
{
    /// <summary>
    /// Holds the #defines for any special strings used in session state. 
    /// </summary>
    ///
    internal static class StringLiterals 
    {
        // constants

        /// <summary>
        /// The separator used in provider base paths. The format is
        /// providerId::providerPath.
        /// </summary>
        internal const string ProviderPathSeparator = "::";

        /// <summary>
        /// The default path separator used by the base implementation of the providers.
        /// </summary>
        /// 
        internal const char DefaultPathSeparator = '\\';
        internal const string DefaultPathSeparatorString = "\\";

        /// <summary>
        /// The alternate path separator used by the base implementation of the providers.
        /// </summary>
        /// 
        internal const char AlternatePathSeparator = '/';
        internal const string AlternatePathSeparatorString = "/";

        /// <summary>
        /// The default path prefix for remote paths. This is to mimic
        /// UNC paths in the file system.
        /// </summary>
        /// 
        internal const string DefaultRemotePathPrefix = "\\\\";

        /// <summary>
        /// The alternate path prefix for remote paths. This is to mimic
        /// UNC paths in the file system.
        /// </summary>
        /// 
        internal const string AlternateRemotePathPrefix = "//";

        /// <summary>
        /// The character used in a path to indicate the home location.
        /// </summary>
        internal const string HomePath = "~";

        /// <summary>
        /// name of the global variable table in Variable scopes of session state. 
        /// </summary>
        internal const string Global = "GLOBAL"; 

        /// <summary>
        /// Name of the current scope variable table of session state.
        /// </summary>
        internal const string Local = "LOCAL";

        /// <summary>
        /// When prefixing a variable "private" makes the variable
        /// only visible in the current scope.
        /// </summary>
        internal const string Private = "PRIVATE";

        /// <summary>
        /// When prefixing a variable "script" makes the variable
        /// global to the scipt but not global to the entire session.
        /// </summary>
        internal const string Script = "SCRIPT";

        /// <summary>
        /// session state string used as resource name in exceptions
        /// </summary>
        internal const string SessionState = "SessionState"; 

#if RELATIONSHIP_SUPPORTED
        // 2004/11/24-JeffJon - Relationships have been removed from the Exchange release

        /// <summary>
        /// The file extension (including the dot) of the relationship provider description file
        /// </summary>
        internal const string RelationshipProviderFileExtension = ".relationshipprovider";
#endif

        /// <summary>
        /// The file extension (including the dot) of an PowerShell script file
        /// </summary>
        internal const string PowerShellScriptFileExtension = ".ps1";

        /// <summary>
        /// The file extension (including the dot) of an PowerShell module file
        /// </summary>
        internal const string PowerShellModuleFileExtension = ".psm1";

        /// <summary>
        /// The file extension (including the dot) of an Mof file
        /// </summary>
        internal const string PowerShellMofFileExtension = ".mof";

        /// <summary>
        /// The file extension (including the dot) of a PowerShell cmdletization file
        /// </summary>
        internal const string PowerShellCmdletizationFileExtension = ".cdxml";

        /// <summary>
        /// The file extension (including the dot) of a PowerShell declarative session configuration file
        /// </summary>
        internal const string PowerShellDISCFileExtension = ".pssc";

        /// <summary>
        /// The file extension (including the dot) of a PowerShell role capability file
        /// </summary>
        internal const string PowerShellRoleCapabilityFileExtension = ".psrc";

        /// <summary>
        /// The file extension (including the dot) of an PowerShell data file
        /// </summary>
        internal const string PowerShellDataFileExtension = ".psd1";

        /// <summary>
        /// The file extension (including the dot) of an workflow file
        /// </summary>
        internal const string WorkflowFileExtension = ".xaml";

        /// <summary>
        /// The file extension (including the dot) of an workflow dependent assembly
        /// </summary>
        internal const string DependentWorkflowAssemblyExtension = ".dll";

        internal const string PowerShellConsoleFileExtension = ".psc1";

        /// <summary>
        /// The default verb/noun separator for a command. verb-noun or verb/noun
        /// </summary>
        internal const char CommandVerbNounSeparator = '-';

        /// <summary>
        /// The default verb to try if the command was not resolved
        /// </summary>
        internal const string DefaultCommandVerb = "get";

        /// <summary>
        /// The default extension for a help file relative to its code assembly name.
        /// </summary>
        internal const string HelpFileExtension = "-Help.xml";

        /// <summary>
        /// The language representation of null.
        /// </summary>
        internal const string DollarNull = "$null";

        /// <summary>
        /// The language representation of null.
        /// </summary>
        internal const string Null = "null";

        /// <summary>
        /// The language representation of false.
        /// </summary>
        internal const string False = "false";

        /// <summary>
        /// The language representation of true.
        /// </summary>
        internal const string True = "true";

        /// <summary>
        /// The escape character used in the language.
        /// </summary>
        internal const string EscapeCharacter = "`";

        /// <summary>
        /// The default cmdlet adapter for cmdletization / cdxml modules
        /// </summary>
        internal const string DefaultCmdletAdapter = "Microsoft.PowerShell.Cmdletization.Cim.CimCmdletAdapter, Microsoft.PowerShell.Commands.Management, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
    }
}