import requests

url = 'http://178.21.117.113:1026/v1/contextEntities/van_heekgarage/attributes/free_spots'
headers = {'Accept': 'application/json'}

r = requests.get(url, headers=headers)

print(r.json())