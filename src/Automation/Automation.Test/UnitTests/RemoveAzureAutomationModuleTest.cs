﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Automation.Cmdlet;
using Microsoft.Azure.Commands.Automation.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.WindowsAzure.Commands.Common.Test.Mocks;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Moq;

namespace Microsoft.Azure.Commands.ResourceManager.Automation.Test.UnitTests
{
    [TestClass]
    public class RemoveAzureAutomationModuleTest : RMTestBase
    {
        private Mock<IAutomationPSClient> mockAutomationClient;

        private MockCommandRuntime mockCommandRuntime;

        private RemoveAzureAutomationModule cmdlet;

        [TestInitialize]
        public void SetupTest()
        {
            this.mockAutomationClient = new Mock<IAutomationPSClient>();
            this.mockCommandRuntime = new MockCommandRuntime();
            this.cmdlet = new RemoveAzureAutomationModule
            {
                AutomationClient = this.mockAutomationClient.Object,
                CommandRuntime = this.mockCommandRuntime
            };
        }

        [TestMethod]
        public void RemoveAzureAutomationModuleByNameSuccessfull()
        {
            // Setup
            string resourceGroupName = "resourceGroup";
            string accountName = "automation";
            string moduleName = "module";

            this.mockAutomationClient.Setup(f => f.DeleteModule(resourceGroupName, accountName, moduleName, false));

            // Test
            this.cmdlet.ResourceGroupName = resourceGroupName;
            this.cmdlet.AutomationAccountName = accountName;
            this.cmdlet.Name = moduleName;
            this.cmdlet.Force = true;
            
            this.cmdlet.ExecuteCmdlet();

            // Assert
            this.mockAutomationClient.Verify(f => f.DeleteModule(resourceGroupName, accountName, moduleName, false), Times.Once());

        }

        [TestMethod]
        public void RemoveAzureAutomationPowershell72ModuleByNameSuccessfull()
        {
            // Setup
            string resourceGroupName = "resourceGroup";
            string accountName = "automation";
            string moduleName = "module";

            this.mockAutomationClient.Setup(f => f.DeleteModule(resourceGroupName, accountName, moduleName, true));

            // Test
            this.cmdlet.ResourceGroupName = resourceGroupName;
            this.cmdlet.AutomationAccountName = accountName;
            this.cmdlet.Name = moduleName;
            this.cmdlet.Force = true;
            this.cmdlet.RuntimeVersion = "7.2";
            this.cmdlet.ExecuteCmdlet();

            // Assert
            this.mockAutomationClient.Verify(f => f.DeleteModule(resourceGroupName, accountName, moduleName, true), Times.Once());
        }
    }
}
