# coding: utf-8

"""
    KAMONOHASHI API

    A platform for deep learning  # noqa: E501

    OpenAPI spec version: v1
    Contact: kamonohashi-support@jp.nssol.nipponsteel.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import pprint
import re  # noqa: F401

import six

from kamonohashi.op.rest.models.data_set_api_models_data_file_output_model_entry import DataSetApiModelsDataFileOutputModelEntry  # noqa: F401,E501


class DataSetApiModelsDataFileOutputModel(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'created_at': 'str',
        'created_by': 'str',
        'display_id': 'int',
        'entries': 'list[DataSetApiModelsDataFileOutputModelEntry]',
        'id': 'int',
        'memo': 'str',
        'modified_at': 'str',
        'modified_by': 'str',
        'name': 'str'
    }

    attribute_map = {
        'created_at': 'createdAt',
        'created_by': 'createdBy',
        'display_id': 'displayId',
        'entries': 'entries',
        'id': 'id',
        'memo': 'memo',
        'modified_at': 'modifiedAt',
        'modified_by': 'modifiedBy',
        'name': 'name'
    }

    def __init__(self, created_at=None, created_by=None, display_id=None, entries=None, id=None, memo=None, modified_at=None, modified_by=None, name=None):  # noqa: E501
        """DataSetApiModelsDataFileOutputModel - a model defined in Swagger"""  # noqa: E501

        self._created_at = None
        self._created_by = None
        self._display_id = None
        self._entries = None
        self._id = None
        self._memo = None
        self._modified_at = None
        self._modified_by = None
        self._name = None
        self.discriminator = None

        if created_at is not None:
            self.created_at = created_at
        if created_by is not None:
            self.created_by = created_by
        if display_id is not None:
            self.display_id = display_id
        if entries is not None:
            self.entries = entries
        if id is not None:
            self.id = id
        if memo is not None:
            self.memo = memo
        if modified_at is not None:
            self.modified_at = modified_at
        if modified_by is not None:
            self.modified_by = modified_by
        if name is not None:
            self.name = name

    @property
    def created_at(self):
        """Gets the created_at of this DataSetApiModelsDataFileOutputModel.  # noqa: E501


        :return: The created_at of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :rtype: str
        """
        return self._created_at

    @created_at.setter
    def created_at(self, created_at):
        """Sets the created_at of this DataSetApiModelsDataFileOutputModel.


        :param created_at: The created_at of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :type: str
        """

        self._created_at = created_at

    @property
    def created_by(self):
        """Gets the created_by of this DataSetApiModelsDataFileOutputModel.  # noqa: E501


        :return: The created_by of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :rtype: str
        """
        return self._created_by

    @created_by.setter
    def created_by(self, created_by):
        """Sets the created_by of this DataSetApiModelsDataFileOutputModel.


        :param created_by: The created_by of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :type: str
        """

        self._created_by = created_by

    @property
    def display_id(self):
        """Gets the display_id of this DataSetApiModelsDataFileOutputModel.  # noqa: E501


        :return: The display_id of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :rtype: int
        """
        return self._display_id

    @display_id.setter
    def display_id(self, display_id):
        """Sets the display_id of this DataSetApiModelsDataFileOutputModel.


        :param display_id: The display_id of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :type: int
        """

        self._display_id = display_id

    @property
    def entries(self):
        """Gets the entries of this DataSetApiModelsDataFileOutputModel.  # noqa: E501


        :return: The entries of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :rtype: list[DataSetApiModelsDataFileOutputModelEntry]
        """
        return self._entries

    @entries.setter
    def entries(self, entries):
        """Sets the entries of this DataSetApiModelsDataFileOutputModel.


        :param entries: The entries of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :type: list[DataSetApiModelsDataFileOutputModelEntry]
        """

        self._entries = entries

    @property
    def id(self):
        """Gets the id of this DataSetApiModelsDataFileOutputModel.  # noqa: E501


        :return: The id of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this DataSetApiModelsDataFileOutputModel.


        :param id: The id of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :type: int
        """

        self._id = id

    @property
    def memo(self):
        """Gets the memo of this DataSetApiModelsDataFileOutputModel.  # noqa: E501


        :return: The memo of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :rtype: str
        """
        return self._memo

    @memo.setter
    def memo(self, memo):
        """Sets the memo of this DataSetApiModelsDataFileOutputModel.


        :param memo: The memo of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :type: str
        """

        self._memo = memo

    @property
    def modified_at(self):
        """Gets the modified_at of this DataSetApiModelsDataFileOutputModel.  # noqa: E501


        :return: The modified_at of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :rtype: str
        """
        return self._modified_at

    @modified_at.setter
    def modified_at(self, modified_at):
        """Sets the modified_at of this DataSetApiModelsDataFileOutputModel.


        :param modified_at: The modified_at of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :type: str
        """

        self._modified_at = modified_at

    @property
    def modified_by(self):
        """Gets the modified_by of this DataSetApiModelsDataFileOutputModel.  # noqa: E501


        :return: The modified_by of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :rtype: str
        """
        return self._modified_by

    @modified_by.setter
    def modified_by(self, modified_by):
        """Sets the modified_by of this DataSetApiModelsDataFileOutputModel.


        :param modified_by: The modified_by of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :type: str
        """

        self._modified_by = modified_by

    @property
    def name(self):
        """Gets the name of this DataSetApiModelsDataFileOutputModel.  # noqa: E501


        :return: The name of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this DataSetApiModelsDataFileOutputModel.


        :param name: The name of this DataSetApiModelsDataFileOutputModel.  # noqa: E501
        :type: str
        """

        self._name = name

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(DataSetApiModelsDataFileOutputModel, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, DataSetApiModelsDataFileOutputModel):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
