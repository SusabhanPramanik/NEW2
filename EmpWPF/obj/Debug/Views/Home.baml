   M S B A M L   `   `   `  ����A  =EmpWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:EmpWPF.ViewsEmpWPF.Views  5   	   5clr-namespace:EmpWPF.ViewModelsEmpWPF.ViewModels  5   	   +clr-namespace:EmpWPF.ViewsEmpWPF.Views  5   	       EmpWPF.Views.Home   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:EmpWPF.Views     5   	   6
viewmodelsclr-namespace:EmpWPF.ViewModels     5   	   ,viewsclr-namespace:EmpWPF.Views     5   	   $
��1123��5
   	   $
��1200��6     � 	Resources  5       �� DataType4   .EmpWPF.ViewModels.ViewEmployeeDetailsViewModel"   EmpWPF.Views.EmployeeDetails � DataContext2   ,EmpWPF.ViewModels.DepartmentDetailsViewModel$   EmpWPF.Views.DepartmentDetails��%�   (��       5   <   *, +)(�� `     5   :   *, +)�� 5   
   ViewEmployeeDetailsTemplate��"  6<   .R�5         6$   �� 5      �� 5   
   DepartmentDetailsTemplate��"  6:   .R�5         6&   �� 5      5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��/EmployeePortal_Logo.png��6   �� 5   
   ��6   �� �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� -   5         ��Name$ BtnLoadEmployeeDetails��5      
����d�$��View Employee Details��6v   $��50��6�   $	��250��6�   $��16(�6�    J� RenderTransformOrigin$ 0.489,0.507&�6�   ��65   �� *GetButtonClicked+6�   �� 5      -   5        $ btnLoadDepartmentDetails��5      $��Department Details��6\   
����d�$��10q�6�   $��50��6�   $	��250��6�   $��16(�6�   $ 0.489,0.507&�6�   ��67   �� *GetButtonClicked+6�   5      5      5      