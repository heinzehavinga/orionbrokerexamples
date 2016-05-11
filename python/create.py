# Using the requests library for making the HTTP calls
# More info on http://docs.python-requests.org/en/master/
import requests

# Updating our test_entity
url = 'http://178.21.117.113:1026/v1/contextEntities/test_entity/'
headers = {'Accept': 'application/json', 'Content-Type': 'application/json'}

#Our payload for the call
#see http://fiware-orion.readthedocs.org/en/develop/user/walkthrough_apiv1/index.html#example-case
#for more info
data = {
            "type": "Project",
            "isPattern": "false",
            "id": "test_entity",
            "attributes": [
                {
                    "name": "test_temperature",
                    "type": "float",
                    "value": 23.6,
                },
                {
                    "name": "test_pressure",
                    "type": "integer",
                    "value": 721,
                }
        	]
} 

# Making the call
r = requests.post(url, headers=headers, json=data)

# Printing the results
print(r)
print(r.content)