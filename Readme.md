<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128618613/10.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2453)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ValidationProviderSuccessEvent/Form1.cs) (VB: [Form1.vb](./VB/ValidationProviderSuccessEvent/Form1.vb))
* [MyValidationProvider.cs](./CS/ValidationProviderSuccessEvent/MyValidationProvider.cs) (VB: [MyValidationProvider.vb](./VB/ValidationProviderSuccessEvent/MyValidationProvider.vb))
<!-- default file list end -->
# Events of successful validation for DXValidationProvider


<p>In this example we have created two new events for DXValidationProvider: ControlValidationSucceded and ValidationSuccessfullyComplete. When handled, the ControlValidationSucceeded event is raised after validation is passed for a single control. The ValidationSuccessfullyComplete event is raised when validation is passed for every controls assigned to DXValidationProvider. If only one control is assigned to DXValidationProvider both these events are raised - first the  ControlValidationSucceded and then ValidationSuccessfullyComplete.</p>

<br/>


