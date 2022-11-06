import myEnv from './env.json';

async function readResponse(response)
{
  let useableResponse = "";
  const readJson = await response.json();
  if(readJson.error)
  {
    useableResponse = readJson.error;
  }
  else if(readJson.errors && readJson.title)
  {
    useableResponse = {error:'Some issue in completing this request'};
    
  }else{
    useableResponse = readJson;
  }
  return useableResponse; 
}
function setupRequest(methodType,data)
{
    return ({
        method: methodType, // *GET, POST, PUT, DELETE, etc.
        headers: {
          'Content-Type': 'application/json'      
        },
        body: JSON.stringify(data) // body data type must match "Content-Type" header
      });
}
async function createUser(data) {
    const requestObj = setupRequest('POST',data);
    const response = await fetch(myEnv.URL+"/user", requestObj);
    return readResponse(response); 
  }

  async function createAdventure(data) {
    const requestObj = setupRequest('POST',data);
    const response = await fetch(myEnv.URL+"/adventure", requestObj);
    return readResponse(response);
  }
  
  async function getAdventure(adventureId) {
    const response = await fetch(myEnv.URL+"/adventure/"+adventureId);
    return readResponse(response);
  }

  async function createUserAdventure(data) {
    const requestObj = setupRequest('POST',data);
    const response = await fetch(myEnv.URL+"/user/create/adventure", requestObj);
    return await readResponse(response);
  }

  async function getUserAdventure(userAdventureId) {
    const response = await fetch(myEnv.URL+"/user/get/adventure/"+userAdventureId);
    return readResponse(response);
  }
  
  

     const Api = {
        createUser: createUser,
        createAdventure: createAdventure,
        getAdventure:getAdventure,
        createUserAdventure:createUserAdventure,
        getUserAdventure:getUserAdventure
      };    

      export default Api;