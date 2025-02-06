// import renderApi from '@api/render-api';

// renderApi.auth('rnd_Nlh9EX0TlnMtkIzbDmGmlG9NPlko');
// renderApi.listServices({includePreviews: 'true', limit: '20'})
//   .then(({ data }) => console.log(data))
//   .catch(err => console.error(err));
//teacher
import express from 'express';
import renderApi from '@api/render-api';

const app = express();
const PORT = process.env.PORT || 3000;

// אימות מול Render API
renderApi.auth('rnd_Nlh9EX0TlnMtkIzbDmGmlG9NPlko');

app.get('/', async (req, res) => {
  try {
    const { data } = await renderApi.listServices({ includePreviews: 'true', limit: '20' });
    res.json(data);
  } catch (err) {
    console.error(err);
    res.status(500).send('Error fetching data from Render API');
  }
});

// הפעלת השרת
app.listen(PORT, () => {
  console.log(`Server is running on port ${PORT}`);
});
//riki
// const express = require('express');
// const renderApi = require('@api/render-api');

// const app = express();
// const PORT = process.env.PORT || 3000;

// // Authentication with Render API
// renderApi.auth('rnd_Nlh9EX0TlnMtkIzbDmGmlG9NPlko');

// app.get('/', async (req, res) => {
//   try {
//     const { data } = await renderApi.listServices({ includePreviews: 'true', limit: '20' });
//     res.json(data);
//   } catch (err) {
//     console.error(err);
//     res.status(500).send('Error fetching data from Render API');
//   }
// });

// // Start the server
// app.listen(PORT, () => {
//   console.log(`Server is running on port ${PORT}`);
// });
