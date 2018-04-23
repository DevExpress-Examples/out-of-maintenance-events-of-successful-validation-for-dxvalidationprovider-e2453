# Events of successful validation for DXValidationProvider


<p>In this example we have created two new events for DXValidationProvider: ControlValidationSucceded and ValidationSuccessfullyComplete. When handled, the ControlValidationSucceeded event is raised after validation is passed for a single control. The ValidationSuccessfullyComplete event is raised when validation is passed for every controls assigned to DXValidationProvider. If only one control is assigned to DXValidationProvider both these events are raised - first the  ControlValidationSucceded and then ValidationSuccessfullyComplete.</p>

<br/>


