### Example 1: Create an environment variable within a container instance
```powershell
New-AzContainerInstanceEnvironmentVariableObject -Name "env1" -Value "value1"
```

```output
Name SecureValue Value
---- ----------- -----
env1             value1
```

This command creates an environment variable within a container instance.

### Example 2: Create a secure environment variable within a container instance
```powershell
$pwd = ConvertTo-SecureString -String "****" -AsPlainText -Force
New-AzContainerInstanceEnvironmentVariableObject -Name "env2" -SecureValue $pwd
```

```output
Name SecureValue Value
---- ----------- -----
env2 ******
```

This command creates a secure environment variable within a container instance
