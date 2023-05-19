const fetchPOST = async (url, data) => {

  fetch(url, {
    method: 'POST',
    body: JSON.stringify(data),
    headers: {
      'Content-Type': 'application/json'
    }
  });

}

const fetchGET = async (url) => {

  let dataResponse;

  await fetch(url)
    .then((response) => response.json())
    .then((data) => {
      dataResponse = data;
    });

  console.log('api response', dataResponse)

  return dataResponse;

}

const fetchDELETE = async (url) => {

  await fetch(url, {
    method: 'DELETE'
  })

}