window.firebaseInterop = {
    uploadFile: function (path, file) {
        return storage.ref(path).put(file).then(snapshot => snapshot.ref.getDownloadURL());
    },
    getFileUrl: function (path) {
        return storage.ref(path).getDownloadURL();
    },
    addDocument: function (collectionName, document) {
        return db.collection(collectionName).add(document);
    }
};