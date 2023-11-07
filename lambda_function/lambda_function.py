import json
import boto3

def lambda_handler(event, context):
    # TODO implement
    
    bucket_name = event['Records'][0]['s3']['bucket']['name']
    
    object_key = event['Records'][0]['s3']['object']['key']
    
    sns_client = boto3.client('sns')
    
    message = f"Se ha cargado una nueva imagen en el bucket S3 {bucket_name}. Nombre del archivo: {object_key}"
    

    sns_topic_arn = 'rn:aws:sns:us-east-2:576036501201:SNSPruebaQualit'
    sns_client.publish(TopicArn=sns_topic_arn, Message=message)
    
    return {
        'statusCode': 200,
        'body': json.dumps('Hello from Lambda!')
    }
