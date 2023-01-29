$rg = 'database-arm'
New-AzResourceGroup -Name $rg -Location northeurope -Force

New-AzResourceGroupDeployment `
    -Name 'new-arm-database' `
    -ResourceGroupName $rg `
    -TemplateFile 'dbArm.json' 