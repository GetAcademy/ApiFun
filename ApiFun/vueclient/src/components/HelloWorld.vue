<template>
  <div class="hello">
    <h1>Terje</h1>
    <table>
      <tr>
        <th>Id</th>
        <th>Navn</th>
        <th>Alder</th>
      </tr>
      <tr v-for="person in people">
        <td>{{person.id}}</td>
        <td>{{person.name}}</td>
        <td>{{person.age}}</td>
      </tr>
    </table>
  </div>
</template>
<script>
  import axios from 'axios'

  export default {
    name: 'HelloWorld',
    data() {
      return {
        people: []
      }
    },
    created: async function () {

      try {
        const response = await axios.get('/api/people');
        console.log(response.data);
        this.people.length = 0;
        this.people.push(...response.data);
      }
      catch (e) {
        console.log(e);
      }
    }
  }
</script>
<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

  h1, h2 {
    font-weight: normal;
  }

  ul {
    list-style-type: none;
    padding: 0;
  }

  li {
    display: inline-block;
    margin: 0 10px;
  }

  a {
    color: #42b983;
  }
</style>
