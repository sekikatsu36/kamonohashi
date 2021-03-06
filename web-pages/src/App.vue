<template>
  <div id="app">
    <el-container>
      <el-header>
        <pl-header @logout="handleLogout" @login="handleLogin" @menu="handleMenu" :login="login"></pl-header>
      </el-header>
      <el-container class="main-container">
        <pl-menu class="sidenav" v-show="menu"></pl-menu>
        <el-main>
          <router-view class="content" :class="{ 'content-hidden': !menu }" @login="handleLogin"/>
        </el-main>
      </el-container>
    </el-container>
  </div>
</template>

<script>
  import api from '@/api/v1/api'
  import Header from '@/components/Header.vue'
  import Menu from '@/components/Menu.vue'
  import Util from '@/util/util'

  export default {
    name: 'App',

    components: {
      'pl-header': Header,
      'pl-menu': Menu
    },

    data () {
      return {
        login: false,
        menu: this.getMenu()
      }
    },

    async mounted () {
      await this.init()
    },

    watch: {
      menu () {
        this.setMenu(this.menu)
      }
    },

    methods: {
      async init () {
        let token = this.getToken()
        if (token) {
          let data = (await api.account.get()).data
          this.login = true
          this.$store.commit('setLogin', {name: data.userName, tenant: data.selectedTenant})
        }
      },

      async handleLogin (name, tenant, token, url) {
        this.login = true
        this.menu = true
        this.setToken(token)
        this.$store.commit('setLogin', {name: name, tenant: tenant})
        this.$router.push(url)
      },
      async handleMenu () {
        this.menu = !this.menu
      },
      async handleLogout () {
        this.login = false
        this.menu = false
        this.deleteToken()
        this.$store.commit('setLogin', {name: '', tenant: ''})
        this.$router.push('/login')
      },
      setToken (token) {
        Util.setCookie('.Platypus.Auth', token)
      },
      deleteToken () {
        Util.deleteCookie('.Platypus.Auth')
      },
      getToken () {
        return Util.getCookie('.Platypus.Auth')
      },
      setMenu (showFlg) {
        Util.setCookie('.Platypus.ShowMenu', showFlg)
      },
      getMenu () {
        let v = Util.getCookie('.Platypus.ShowMenu')
        return (v === 'true')
      }

    }
  }
</script>

<style lang="scss" scoped>
  #app {
    color: #2c3e50;

    $header-height: 50px;
    $menu-back-color: #fafafa;

    .el-header {
      height: $header-height !important;
      position: fixed;
      width: 100%;
      z-index: 2;
      margin-top: 0%;
      top: 0px;
      left: 0px;
      background-color: #1abfd5;
      border-bottom: 1px solid #cccccc;
      /*color: white;*/

      background: linear-gradient(to bottom, rgba(26, 191, 213, 1) 0%, rgba(26, 191, 213, 1) 30%, rgba(26, 191, 213, 0.7) 100%);
      filter: alpha(opacity=90);
      -moz-opacity: 0.9;
      opacity: 0.9;
    }

    .el-menu {
    }

    .sidenav {
      margin-top: $header-height;
      height: 100%;
      position: fixed;
      z-index: 1;
      top: 0;
      left: 0;
      overflow-x: hidden;
      background-color: $menu-back-color;
      box-shadow: inset -2px 0 0 #e5e5e5;
    }
    @media screen and (max-width: 1000px) {
      .sidenav {
        width: 65px;
      }
    }
    @media screen and (min-width: 1000px) {
      .sidenav {
        width: 200px;
      }
    }

    .el-main {
      padding-top: $header-height;
      height: 100vh;
    }

    // Components Common style
    .el-transfer-panel {
      width: 40% !important;

    }

    .content {
    }
    @media screen and (max-width: 1000px) {
      .content {
        margin-left: 65px;
      }
    }
    @media screen and (min-width: 1000px) {
      .content {
        margin-left: 200px;
      }
    }
  }

  .content-hidden {
    margin-left: 0px !important;
  }

  .fade-enter-active,
  .fade-leave-active {
    transition: opacity .5s;
  }

  .fade-enter, .fade-leave-to /* .fade-leave-active below version 2.1.8 */
  {
    opacity: 0;
  }
</style>

<style src="./reset.css"/>
<style src="./style.css"/>
