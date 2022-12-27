# Commands to test

- Synchronous Call

  - `aws lambda invoke --function-name ExampleAWSWebApiSearchCep --cli-binary-format raw-in-base64-out --payload '{ "path": "api/address/44077200", "httpMethod": "GET" }' response.json`

- Asynchronous Call

  - `aws lambda invoke --function-name ExampleAWSWebApiSearchCep --cli-binary-format raw-in-base64-out --payload '{ "path": "api/address/44077200", "httpMethod": "GET" }' --invocation-type Event --region sa-east-1 response.json`

- AWS Console Lambda Test

```
{
  "path": "api/address/44077200",
  "httpMethod": "GET"
}
```

# Points of attention

- In file LambdaEntryPoint.cs
- This class extends from APIGatewayProxyFunction which contains the method FunctionHandlerAsync which is the actual Lambda function entry point. The Lambda handler field should be set to `ExampleAWSWebApiSearchCep::ExampleAWSWebApiSearchCep.LambdaEntryPoint::FunctionHandlerAsync`

- `<PublishReadyToRun>false</PublishReadyToRun>`

```

```
