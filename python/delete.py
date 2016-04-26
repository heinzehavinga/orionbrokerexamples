# Volgens het ngsi10 protocool

import requests

url = 'http://178.21.117.113:1026/v1/contextEntities/test_entity2'
headers = {'Accept': 'application/json', 'Content-Type': 'application/json'}

r = requests.delete(url, headers=headers)

print(r)
print(r.content)